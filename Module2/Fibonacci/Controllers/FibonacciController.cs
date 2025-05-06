using Microsoft.AspNetCore.Mvc;

namespace Fibonacci.Controllers {
    [ApiController]
    [Route("[controller]")]
    public class FibonacciController : ControllerBase {
        [HttpGet(Name = "GetFibonacciSequence")]
        public IEnumerable<long> Index(int length) {
            List<long> sequence = [];
            if (length <= 0) {
                return sequence;
            }

            long a = 1, b = 1;

            sequence.Add(a);
            if (length == 1) {
                return sequence;
            }
                
            sequence.Add(b);

            for (int i = 2; i < length; i++) {
                long next = a + b;
                sequence.Add(next);
                a = b;
                b = next;
            }

            return sequence;
        }
    }
}
