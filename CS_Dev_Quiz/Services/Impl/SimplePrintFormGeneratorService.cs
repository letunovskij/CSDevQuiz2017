using CS_Dev_Quiz.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Dev_Quiz.Services.Impl
{
    class SimplePrintFormGeneratorService : IPrintFormGenerator
    {
        public byte[] GeneratePrintForm(Document document)
        {
            return new byte[] {
                0x11,
                0x12,
                0x13,
                0x14,
                0x15
            };
        }
    }
}
