using System;

namespace VendingMachine.Entities
{
    public class DisplayMessage
    {

        private DateTime _generatedDateTime;
        private string _MessageText;

        public DisplayMessage(string MessageText)
        {
            this._MessageText = MessageText;
            this._generatedDateTime = DateTime.Now;
        }

        public string MessageText { get { return this._MessageText; } }
        public DateTime GeneratedDateTime { get { return this._generatedDateTime; } }

    }
}