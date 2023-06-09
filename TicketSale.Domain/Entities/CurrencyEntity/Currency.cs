﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketSale.Domain.Entities.CurrencyEntity
{
    public class Currency
    {
        public CurrencyJson USDBRL { get; set; }
    }

    public class CurrencyJson
    {
        public string code { get; set; }
        public string codein { get; set; }
        public string name { get; set; }
        public string high { get; set; }
        public string low { get; set; }
        public string varBid { get; set; }
        public string pctChange { get; set; }
        public string bid { get; set; }
        public string ask { get; set; }
        public string timestamp { get; set; }
        public string create_date { get; set; }
    }
}
