# RIP, GAC

I registered the [ripgac.net](http://ripgac.net) domain as soon as I heard about Project K, or ASP.NET vNext.
Then, when Microsoft released the alpha bits, I built the site using them, and it was pretty easy.

Also: I don't work for Microsoft, this is not meant to be marketing or anything for them, it's just a thing I'm excited about, OK?

## Tech

It's a very basic MVC application with some views and stuff, and Static Files middleware that runs on OWIN (without the owin.dll, yay).

Things to note: most of the Controller classes don't inherit Controller. That's not required anymore, although it's still there if you want it for convenience. The one Controller that does inherit is AboutController, which uses ViewBag. I could have got that injected, probably, but it makes a point quite well.

## Building & running

If you want to clone/fork this repo and play with it, you'll need the vNext bits installed. Head over to the [Home](http://github.com/aspnet/home) repo and follow the instructions there to get up and running. When you've done that, you should be able to clone this, CLI to the src folder and run `kpm restore` and then `k web`.

If either of those don't work, make sure you've got an `svr50` runtime selected in `kvm`. The `svrc50` builds don't work just yet (feel free to send me a PR fixing that statement if you're reading it and it's not true, future person).

## Limitations

So, you can't edit this in Visual Studio yet, again, that's supposed to be coming "real soon". I've been using Sublime with the occasional Brackets.

Also, you have to specify the Razor Layout in each View, there's no ViewStart support yet.
