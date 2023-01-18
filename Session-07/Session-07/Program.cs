
using Session_07;

ActionRequest request = new ActionRequest();
    request.Input = "Vlasis";
request.Action = ActionEnum.Uppercase;


ActionResponse response = new ActionResponse();

ActionResolver resolver = new ActionResolver();

response = resolver.Execute(request);

resolver.Logger.ReadAll();

Console.ReadLine();

