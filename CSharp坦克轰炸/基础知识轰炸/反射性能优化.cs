﻿//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;

//namespace 基础知识轰炸
//{

//    //方法的调用 最常见的是直接调用，然后也可以用反射进行调用。但是反射调用会影响性能。
//    //所以需要对反射 进行优化。不过我们这一篇不讲Emit生成IL进行反射优化。
//    //我们去寻找替代方案。这就是我们这一篇的运用Expression来实现方法调用。
//    //我们知道 委托可以实现对方法的调用，而且经测试性能虽然不如 直接调用，但也比反射调用好很多。也就是说我们只要能分析 一个方法的
//    //结构 然后生成匹配的委托即可。如果分析方法的结构 生成对应的委托，这是要点。要用到我们的expression Lambda来了。
//    //得到一个委托类型的关键是什么？ 参数 以及 返回值 就可以了。当然方法是否static也要考虑一下。
//    class 反射性能优化
//    {
//    }
//}
