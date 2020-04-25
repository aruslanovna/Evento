﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Evento.DTO.Entities
{
    public class Comment : Entity
    {
        public string EventComment { get; set; }

        public Subscription Subscription { get; set; }

        public int SubscriptionId { get; set; }
    }
}
