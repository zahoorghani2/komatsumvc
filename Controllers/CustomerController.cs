using Assignment1.Models;
using Microsoft.AspNetCore.Mvc;


namespace Assignment1.Controllers;

public class CustomerController : Controller
{
    [HttpPost]
    public JsonResult GetList([FromBody]  List<Customer> model)
    {
        // var list = new List<Customer>();
        // list.Add(model);
        // return Json(new {data = model}, new System.Text.Json.JsonSerializerOptions());

        List<Customer> l = new List<Customer>
        {
            new Customer { 
                RequestNumber = "R-0000509-PR", 
                PortNumber = "207-4-2334",
                PortDesc = "COVER",
                RequestType = "OEM Competitor",
                DistributorCode = "6460",
                BranchCode = 242,
                DelearNetPrice = "$ 29342" 
                },

            new Customer {
                RequestNumber = "R-0000511-PR",
                PortNumber = "520-4-2384",
                PortDesc = "SEAT BELT",
                RequestType = "OEM Competitor",
                DistributorCode = "2313",
                BranchCode = 321,
                DelearNetPrice = "$ 29342"
                },

            new Customer {
                RequestNumber = "R-0000542-PR",
                PortNumber = "736-4-0232",
                PortDesc = "BOLT",
                RequestType = "OEM Competitor",
                DistributorCode = "7564",
                BranchCode = 534,
                DelearNetPrice = "$ 2342"
                },

            new Customer {
                RequestNumber = "R-0000542-PR",
                PortNumber = "736-4-0232",
                PortDesc = "BOLT",
                RequestType = "OEM Competitor",
                DistributorCode = "7564",
                BranchCode = 534,
                DelearNetPrice = "$ 2342"
                },

            new Customer {
                RequestNumber = "R-0000542-PR",
                PortNumber = "736-4-0232",
                PortDesc = "BOLT",
                RequestType = "OEM Competitor",
                DistributorCode = "7564",
                BranchCode = 534,
                DelearNetPrice = "$ 2342"
                },


            new Customer {
                RequestNumber = "R-0000542-PR",
                PortNumber = "736-4-0232",
                PortDesc = "BOLT",
                RequestType = "OEM Competitor",
                DistributorCode = "7564",
                BranchCode = 534,
                DelearNetPrice = "$ 2342"
                },


            new Customer {
                RequestNumber = "R-0000542-PR",
                PortNumber = "736-4-0232",
                PortDesc = "BOLT",
                RequestType = "OEM Competitor",
                DistributorCode = "7564",
                BranchCode = 534,
                DelearNetPrice = "$ 2342"
                },

            new Customer {
                RequestNumber = "R-0000542-PR",
                PortNumber = "736-4-0232",
                PortDesc = "BOLT",
                RequestType = "OEM Competitor",
                DistributorCode = "7564",
                BranchCode = 534,
                DelearNetPrice = "$ 2342"
                },

            new Customer {
                RequestNumber = "R-0000542-PR",
                PortNumber = "736-4-0232",
                PortDesc = "BOLT",
                RequestType = "OEM Competitor",
                DistributorCode = "7564",
                BranchCode = 534,
                DelearNetPrice = "$ 2342"
                },

            new Customer {
                RequestNumber = "R-0000542-PR",
                PortNumber = "736-4-0232",
                PortDesc = "BOLT",
                RequestType = "OEM Competitor",
                DistributorCode = "7564",
                BranchCode = 534,
                DelearNetPrice = "$ 2342"
                },

            new Customer {
                RequestNumber = "R-0000542-PR",
                PortNumber = "736-4-0232",
                PortDesc = "BOLT",
                RequestType = "OEM Competitor",
                DistributorCode = "7564",
                BranchCode = 534,
                DelearNetPrice = "$ 2342"
                },

            new Customer {
                RequestNumber = "R-0000542-PR",
                PortNumber = "736-4-0232",
                PortDesc = "BOLT",
                RequestType = "OEM Competitor",
                DistributorCode = "7564",
                BranchCode = 534,
                DelearNetPrice = "$ 2342"
                },

            new Customer {
                RequestNumber = "R-0000542-PR",
                PortNumber = "736-4-0232",
                PortDesc = "BOLT",
                RequestType = "OEM Competitor",
                DistributorCode = "7564",
                BranchCode = 534,
                DelearNetPrice = "$ 2342"
                },

            new Customer {
                RequestNumber = "R-0000542-PR",
                PortNumber = "736-4-0232",
                PortDesc = "BOLT",
                RequestType = "OEM Competitor",
                DistributorCode = "7564",
                BranchCode = 534,
                DelearNetPrice = "$ 2342"
                },

            new Customer {
                RequestNumber = "R-0000542-PR",
                PortNumber = "736-4-0232",
                PortDesc = "BOLT",
                RequestType = "OEM Competitor",
                DistributorCode = "7564",
                BranchCode = 534,
                DelearNetPrice = "$ 2342"
                },
        };

        return Json(new {data = l}, new System.Text.Json.JsonSerializerOptions());
    }
}