﻿
using Session_07;

ActionRequest request = new ActionRequest();
ActionResponse response = new ActionResponse();
ActionResolver resolver = new ActionResolver();
response = resolver.Execute(request);

