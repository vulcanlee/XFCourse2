using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prism.Events;
using XFToast.Models;

namespace XFToast.Services
{
    public class ToastEvent:PubSubEvent<ToastMessage>
    {
    }
}
