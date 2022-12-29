using Discount.Grpc.Protos;
using Grpc.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Discount.Grpc.Services
{
    public class TestService : TestProtoService.TestProtoServiceBase
    {
        public override async Task<TestResponse> GetName(TestRequest request, ServerCallContext context)
        {
            await Task.Delay(200);
            TestResponse res = new TestResponse();
            if (request.Id == 1) res.Name = "Shareek";
            else if (request.Id == 2) res.Name = "Naasiha";
            return res;
        }
    }
}
