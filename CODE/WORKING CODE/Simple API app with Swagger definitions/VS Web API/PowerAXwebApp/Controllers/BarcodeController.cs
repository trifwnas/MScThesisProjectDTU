using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Swashbuckle.Swagger.Annotations;
using ZXing;
using ZXing.Common;

namespace PowerAXwebApp.Controllers
{
    public class BarcodeController : ApiController
    {

        [SwaggerOperation("GetBarcodes")]
        public IEnumerable<Barcode> Get()
        {
            return barcodes;
        }

        public class Barcode
        {
            public string ID { get; set; }
            public string Number { get; set; }
        }

        static List<Barcode> barcodes = new List<Barcode>()
        {
            new Barcode() { ID = "01", Number = "Barcode 001"},
            new Barcode() { ID = "02", Number = "Barcode 002"},
            new Barcode() { ID = "03", Number = "Barcode 003"},
            new Barcode() { ID = "04", Number = "Barcode 004"},
        };
    }

}
