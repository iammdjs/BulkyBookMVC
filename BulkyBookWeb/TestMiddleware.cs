namespace BulkyBookWeb
{
    public class TestMiddleware
    {
        private readonly RequestDelegate _next;

        public TestMiddleware(RequestDelegate next)
        {
            _next = next;
        }
        public async Task InvokeAsync(HttpContext context)
        {
            Console.WriteLine("Inside the middleware.");
            await _next(context);
        }
    }
}
