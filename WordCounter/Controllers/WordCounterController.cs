using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using WordCounter.Models;

namespace WordCounter.Controllers {

    public class WordCounterController : Controller {

        [HttpGet ("/form")]
        public ActionResult Index () {
            return View ();
        }

        [HttpPost ("/count")]
        public ActionResult Count () {
            WordCount count = new WordCount (Request.Form["searchWord"], Request.Form["sentence"]);
            return View (count);
        }
    }
}