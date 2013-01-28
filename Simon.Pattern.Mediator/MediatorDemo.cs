using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Simon.Pattern.Mediator
{
    /// <summary>
    /// Mediator Pattern
    /// 用一个对象将一系列对象的交互封装，
    /// 从而降低这些对象间的耦合性并且可以独立的改变对象间的交互关系
    /// </summary>
    public class MediatorDemo
    {
        public static void Run()
        {
            Chatroom chatroom = new Chatroom();

            Participant George = new Beatle("Geogre");
            Participant Paul = new Beatle("Paul");
            Participant Ringo = new Beatle("Ringo");
            Participant John = new Beatle("John");
            Participant Yoko = new NonBeatle("Yoko");
            chatroom.Register(George);
            chatroom.Register(Paul); 
            chatroom.Register(Ringo); 
            chatroom.Register(John); 
            chatroom.Register(Yoko); 
            // Chatting participants 
            Yoko.Send ("John", "Hi John!"); 
            Paul.Send ("Ringo", "All you need is love"); 
            Ringo.Send("George", "My sweet Lord"); 
            Paul.Send ("John", "Can't buy me love"); 
            John.Send ("Yoko", "My sweet love") ;
        }
    }
}
