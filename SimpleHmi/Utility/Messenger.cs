using Prism.Events;

namespace SimpleHmi.Utility
{
    internal class FileSelectedGlobalEvent : PubSubEvent<string>
    {
        private static readonly EventAggregator _eventAggregator;
        private static readonly FileSelectedGlobalEvent _event;

        static FileSelectedGlobalEvent()
        {
            _eventAggregator = new EventAggregator();
            _event = _eventAggregator.GetEvent<FileSelectedGlobalEvent>();
        }

        public static FileSelectedGlobalEvent Instance
        {
            get { return _event; }
        }
    }
}
