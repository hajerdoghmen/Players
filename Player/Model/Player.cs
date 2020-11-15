﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Player
    {
        public int id { get; set; }
        public string firstname { get; set; }
        public string lastname { get; set; }
        public string shortname { get; set; }
        public string sex { get; set; }
        public Country country { get; set; }
        public string picture { get; set; }
        public Data data { get; set; }
    }

}
