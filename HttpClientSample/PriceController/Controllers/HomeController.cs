using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Timers;
using System.Web;
using System.Web.Mvc;

namespace PriceController.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }

        private static ConcurrentBag<StreamWriter> clients;
        private static Random random;
        private static Timer timer;

        static void PriceController()
        {
            clients = new ConcurrentBag<StreamWriter>();

            timer = new Timer();
            timer.Interval = 2000;
            timer.AutoReset = true;
            timer.Elapsed += timer_Elapsed;
            timer.Start();

            random = new Random();
        }

        private async static void timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            var price = 1.0 + random.NextDouble(); // random number between 1 and 2

            foreach (var client in clients)
            {
                try
                {
                    var data = string.Format("data: {0}\n\n", price);
                    await client.WriteAsync(data);
                    await client.FlushAsync();
                }
                catch (Exception)
                {
                    StreamWriter ignore;
                    clients.TryTake(out ignore);
                }
            }
        }

        [HttpGet]
        public HttpResponseMessage Subscribe(HttpRequestMessage request)
        {
            var response = request.CreateResponse();
            response.Content = new PushStreamContent((a, b, c) =>
            { OnStreamAvailable(a, b, c); }, "text/event-stream");
            return response;
        }

        private void OnStreamAvailable(Stream stream, HttpContent content, TransportContext context)
        {
            var client = new StreamWriter(stream);
            clients.Add(client);
        }
    }
}
