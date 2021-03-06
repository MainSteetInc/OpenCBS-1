﻿using OpenCBS.CoreDomain;
using OpenCBS.CoreDomain.Events.Saving;
using OpenCBS.Manager.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OpenCBS.Services.Events
{
    public partial class SavingEventServices : Services
    {
        private readonly SavingEventManager _manager;

        public SavingEventServices(User user)
        {
            _manager = new SavingEventManager(user);
        }        

        public List<SavingEvent> SelectByCode(string code)
        {
            return _manager.SelectEvents(code);
        }

        public List<SavingEvent> SelectByTellerId(int tellerId)
        {
            return _manager.SelectEventsByTellerId(tellerId);
        }
    }
}
