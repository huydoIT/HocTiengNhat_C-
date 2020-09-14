using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using FireSharp.Config;
using FireSharp.Response;
using FireSharp.Interfaces;
using System.Windows;

namespace HocTiengNhat
{
    public class DataConnect
    {
        public IFirebaseConfig getConfig()
        {
            IFirebaseConfig ifc = new FirebaseConfig()
            {
                AuthSecret = "DGf5cJ8AcEYEVYMuxDA12NOli8Vk1Tm1s0lXIiz5",
                BasePath = "https://fir-d5946.firebaseio.com/"
            };
            return ifc;
        }

        public IFirebaseClient getClient()
        {
            IFirebaseConfig config = getConfig();
            IFirebaseClient client;
            client = new FireSharp.FirebaseClient(config);

            return client;
        }
        
    }
}
