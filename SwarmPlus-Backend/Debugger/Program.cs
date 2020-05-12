using GetVenuePhotos.models;
using System;

namespace Debugger
{
    class Program
    {
        static async System.Threading.Tasks.Task Main(string[] args)
        {
            GetVenuePhotos.Function fnc = new GetVenuePhotos.Function();
            Photos photos = await fnc.FunctionHandler(new Request { venueId = "52ee4abd498ef7a7403e9441" }, new Amazon.Lambda.TestUtilities.TestLambdaContext());

            Console.WriteLine(photos);
            Console.ReadKey();
        }
    }
}
