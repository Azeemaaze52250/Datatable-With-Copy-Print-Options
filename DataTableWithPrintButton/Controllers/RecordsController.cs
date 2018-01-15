using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DataTableWithPrintButton.Models;

namespace DataTableWithPrintButton.Controllers
{
    public class RecordsController : Controller
    {
        public IActionResult Index()
        {

            Records rd1 = new Records();
            Records rd2 = new Records();
            Records rd3 = new Records();
            Records rd4 = new Records();
            Records rd5 = new Records();
            Records rd6 = new Records();
            Records rd7 = new Records();
            Records rd8 = new Records();
            Records rd9 = new Records();
            Records rd10 = new Records();

            rd1.SNo = 1;
            rd1.Id = 1001;
            rd1.UserName = "User 1";
            rd1.FatherName = "Father 1";

            rd2.SNo = 2;
            rd2.Id = 2002;
            rd2.UserName = "User 2";
            rd2.FatherName = "Father 2";

            rd3.SNo = 3;
            rd3.Id = 3003;
            rd3.UserName = "User 3";
            rd3.FatherName = "Father 3";

            rd4.SNo = 4;
            rd4.Id = 4004;
            rd4.UserName = "User 4";
            rd4.FatherName = "Father 4";

            rd5.SNo = 5;
            rd5.Id = 5005;
            rd5.UserName = "User 5";
            rd5.FatherName = "Father 5";

            rd6.SNo = 6;
            rd6.Id = 6006;
            rd6.UserName = "User 6";
            rd6.FatherName = "Father 6";

            rd7.SNo = 7;
            rd7.Id = 7007;
            rd7.UserName = "User 7";
            rd7.FatherName = "Father 7";

            rd8.SNo = 8;
            rd8.Id = 8008;
            rd8.UserName = "User 8";
            rd8.FatherName = "Father 8";

            rd9.SNo = 9;
            rd9.Id = 9009;
            rd9.UserName = "User 9";
            rd9.FatherName = "Father 9";

            rd10.SNo = 10;
            rd10.Id = 1000;
            rd10.UserName = "User 10";
            rd10.FatherName = "Father 10";

            IList<Records> rl = new List<Records>();

            rl.Add(rd1);
            rl.Add(rd2);
            rl.Add(rd3);
            rl.Add(rd4);
            rl.Add(rd5);
            rl.Add(rd6);
            rl.Add(rd7);
            rl.Add(rd8);
            rl.Add(rd9);
            rl.Add(rd10);

            return View(rl);
        }
    }
}