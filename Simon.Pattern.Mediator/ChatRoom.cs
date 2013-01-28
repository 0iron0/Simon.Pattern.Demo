using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace Simon.Pattern.Mediator
{
    public abstract class ChatroomBase
    {
        public abstract void Register(Participant participant);
        public abstract void Send(string from, string to, string message);
    }

    public class Chatroom : ChatroomBase
    {
        private Hashtable participants = new Hashtable();
        public override void Register(Participant participant)
        {
            if (participants[participant.Name] == null)
            {
                participants[participant.Name] = participant;
            }
            participant.Room = this;
        }
        public override void Send(string from, string to, string message)
        {
            Participant pto = (Participant)participants[to];
            if (pto != null)
            {
                pto.Receive(from, message);
            }
        }
    }

    public class Participant
    {
        private string name;
        // Constructor 
        public Participant(string name)
        {
            this.name = name;
        }
        // Properties 
        public string Name
        {
            get
            {
                return name;
            }
        }
        public Chatroom Room { get; set; }
        public void Send(string to, string message)
        {
            this.Room.Send(name, to, message);
        }
        public virtual void Receive(string from, string message)
        {
            Console.WriteLine("{0} to {1}: '{2}'", from, Name, message);
        }
    }

    public class Beatle : Participant
    {
        // Constructor 
        public Beatle(string name) : base(name) { }
        public override void Receive(string from, string message)
        {
            Console.Write("To a Beatle: ");
            base.Receive(from, message);
        }
    }

    public class NonBeatle : Participant
    {
        // Constructor 
        public NonBeatle(string name) : base(name) { }
        public override void Receive(string from, string message)
        {
            Console.Write("To a non-Beatle: ");
            base.Receive(from, message);
        }
    }
}
