using System;

namespace Core.ServiceCalls
{
    public class VoiceServiceCall : IServiceCall
    {
        public DateTime Start { get; private set; }
        public TimeSpan Duration { get; private set; }
        public string PhoneNumber { get; private set; }
        public string DestinationPhoneNumber { get; private set; }
        public string FromCountry { get; private set; }
        public string ToCountry { get; private set; }

        public VoiceServiceCall(string sourcePhoneNumber, DateTime start, TimeSpan duration, string destinationPhoneNumber, string fromCountry, string toCountry)
        {
            Start = start;
            Duration = duration;
            PhoneNumber = sourcePhoneNumber;
            DestinationPhoneNumber = destinationPhoneNumber;
            FromCountry = fromCountry;
            ToCountry = toCountry;
        }

        public DateTime GetStartTime()
        {
            return Start;
        }

        public decimal GetUnitSize()
        {
            return Convert.ToDecimal(Duration.TotalSeconds);
        }

        public override string ToString()
        {
            return string.Format("VoiceCall to {0}, lasted {1}.", DestinationPhoneNumber, Duration);
        }
    }
}