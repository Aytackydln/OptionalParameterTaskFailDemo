
Console.WriteLine("FunctionWithOptional");
RunTaskSuccess(FunctionWithOptional);
Thread.Sleep(100);

Console.WriteLine("FunctionWithOptional");
await RunTaskFails(FunctionWithOptional);
Thread.Sleep(100);

async Task RunTaskFails(Delegate task)
{
    await Task.Run(() => task.DynamicInvoke());
}

void RunTaskSuccess(Delegate task)
{
    Task.Run(() => task.DynamicInvoke());
}

async Task FunctionWithOptional(string? parameter = null)
{
    Console.WriteLine("Method ran! " + parameter);
}