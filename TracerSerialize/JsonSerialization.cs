using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.IO;
using Tracer;

namespace TracerSerialize
{
    public class JsonTraceResultSerialization
    {
        public static string Serialize(TraceResult result)
        {
            string res = JsonSerializer.Serialize<TraceResult>(result);
            return res;
        }
    }
}
