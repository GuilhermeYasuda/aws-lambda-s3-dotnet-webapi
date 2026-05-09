using Amazon.S3;
using Microsoft.AspNetCore.Mvc;

namespace AWSLambdaS3.Demo.Controllers
{
    [ApiController]
    public class BucketsController : ControllerBase
    {
        private readonly IAmazonS3 _s3Cliente;
        public BucketsController(IAmazonS3 s3Cliente)
        {
            _s3Cliente = s3Cliente;
        }

        [HttpGet("list")]
        public async Task<IActionResult> ListAsync()
        {
            var response = await _s3Cliente.ListBucketsAsync();
            var buckets = response.Buckets.Select(b => { return b.BucketName; });
            return Ok(buckets);
        }
    }
}
