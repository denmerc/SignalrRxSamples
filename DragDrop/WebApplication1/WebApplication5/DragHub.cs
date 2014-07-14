﻿using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Hubs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication5
{
    [HubName("myDrag")]
    public class DragHub : Hub
    {
        public void ItemDragged(int x, int y)
        {
            Clients.Others.onDrag(new { X = x, Y = y });
        }
    }
}