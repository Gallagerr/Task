﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Net;

namespace Task
{
  public class E_mail : Entity
  {
    public MailAddress From { get; set; }
    public MailAddress To { get; set; }


  }
}
