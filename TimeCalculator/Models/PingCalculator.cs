using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Net.NetworkInformation;

namespace CalculatorCode.Models
{
    public class PingCalculator : Calculator
    {
        [RegularExpression(@"^(([0-9]|[1-9][0-9]|1[0-9]{2}|2[0-4][0-9]|25[0-5])\.){3}([0-9]|[1-9][0-9]|1[0-9]{2}|2[0-4][0-9]|25[0-5])$", ErrorMessage = "Please enter a valid IPv4 address")]
        new public String InputOne { get; set; }
        new public String Result { get; set; }


        public String CalculatePingTime()
        {
            Ping ping = new Ping();
            PingReply reply = ping.Send(InputOne);

            if (!reply.ToString().Equals("Success"))
            {
                return Convert.ToString(reply.RoundtripTime);
            }
            else
            {
                return reply.ToString();
            }

        }


    }

}