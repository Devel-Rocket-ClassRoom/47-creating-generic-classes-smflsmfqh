using System;

ObjectPool<Bullet> Guns = new ObjectPool<Bullet>(3);
Bullet bullet1 = Guns.Get();
Bullet bullet2 = Guns.Get();
Bullet bullet3 = Guns.Get();
//Guns.Get();

Console.WriteLine("=== 총알 발사 ===");
bullet1.Fire(10, 20);
bullet2.Fire(30, 40);
bullet3.Fire(50, 60);
Console.WriteLine($"활성: {Guns.ActiveCount}, 비활성: {Guns.AvailableCount}");
Console.WriteLine();
Console.WriteLine("=== 풀 초과 시도 ===");
Bullet bullet4 = Guns.Get();
Console.WriteLine();
Console.WriteLine("=== 반납 후 재사용 ===");
Guns.Return(bullet3);
Console.WriteLine($"활성: {Guns.ActiveCount}, 비활성: {Guns.AvailableCount}");
Bullet bullet5 = Guns.Get();
bullet5.Fire(100, 200);
Console.WriteLine($"활성: {Guns.ActiveCount}, 비활성: {Guns.AvailableCount}");

