using Discount.Grpc.Protos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Basket.API.GrpcServices
{
    public class DiscountGrpcService
    {
        private readonly DiscountProtoService.DiscountProtoServiceClient _discountProtoService;
        private readonly TestProtoService.TestProtoServiceClient _testProtoService;

        public DiscountGrpcService(DiscountProtoService.DiscountProtoServiceClient discountProtoService, TestProtoService.TestProtoServiceClient testProtoService)
        {
            _discountProtoService = discountProtoService ?? throw new ArgumentNullException(nameof(discountProtoService));
            _testProtoService = testProtoService ?? throw new ArgumentNullException(nameof(testProtoService));
        }

        public async Task<CouponModel> GetDiscount(string productName)
        {
            var discountRequest = new GetDiscountRequest { ProductName = productName };


            return await _discountProtoService.GetDiscountAsync(discountRequest);
        }

        public async Task<TestResponse> GetName(int id)
        {
            var testRequest = new TestRequest { Id = id };
            return await _testProtoService.GetNameAsync(testRequest);
        }
    }
}
