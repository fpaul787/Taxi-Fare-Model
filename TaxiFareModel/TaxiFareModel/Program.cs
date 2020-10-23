using System;
using TaxiFareModelML.Model;

namespace TaxiFareModel
{
    class Program
    {
        static void Main(string[] args)
        {
            // Add input data
            var input = new ModelInput();
            
            input.Vendor_id = "CMT";
            input.Rate_code = 1;
            input.Passenger_count = 1;
            input.Trip_time_in_secs = 869;
            input.Trip_distance = 2.3F;
            input.Payment_type = "CRD";

            // Load model and predict output of sample data
            ModelOutput result = ConsumeModel.Predict(input);
            Console.WriteLine($"Model Result: {result.Score}");
        }
    }
}
