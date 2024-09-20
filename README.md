1. Добавляем библиотеки из Pulse/Release в проект (Для этого в основном проекте нажмем правой кнопкой на узел Dependencies и в контекстном меню выберем пункт Add Project Reference...)
2. Пользуемся

Пример:
```c#
using Pulse;
using Pulse.Components; 

foreach (PulsePost post in await new PulseStore("GMKN").GetPosts()) 
{
    Console.WriteLine(post + "\n\n\n");  
}
```
