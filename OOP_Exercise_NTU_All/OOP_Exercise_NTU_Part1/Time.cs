
namespace OOP_Exercise_NTU_All
{
    class Time
    {
        private int hour, minute, second;

        public void SetHour(int hour)
        {
            if (hour >= 0 && hour <= 23)
            {
                this.hour = hour;
            }
        }

        public void SetMinute(int minute)
        {
            if (minute >= 0 && minute <= 59)
            {
                this.minute = minute;
            }
        }

        public void SetSecond(int second)
        {
            if (second >= 0 && second <= 59)
            {
                this.second = second;
            }
        }

        public Time(int hour, int minute, int second)
        {
            this.SetHour(hour);
            this.SetMinute(minute);
            this.SetSecond(second);
        }

        public int GetHour()
        {
            return this.hour;
        }

        public int GetMinute()
        {
            return this.minute;
        }

        public int GetSecond()
        {
            return this.second;
        }

        public void SetTime(int hour, int minute, int second)
        {
            this.SetHour(hour);
            this.SetMinute(minute);
            this.SetSecond(second);
        }

        public override string ToString()
        {
            System.Text.StringBuilder strBuilder = new System.Text.StringBuilder();
            strBuilder.Append(this.hour.ToString().PadLeft(2, '0') + ":");
            strBuilder.Append(this.minute.ToString().PadLeft(2, '0') + ":");
            strBuilder.Append(this.second.ToString().PadLeft(2, '0'));
            return strBuilder.ToString();
        }

        public Time NextSecond()
        {
            Time result = new Time(this.hour, this.minute, this.second);
            result.second += 1;
            if (result.second == 60)
            {
                result.second = 0;
                result.minute += 1;
                if (result.minute == 60)
                {
                    result.minute = 0;
                    result.hour += 1;
                }
            }
            return result;
        }

        public Time PreviousSecond()
        {
            Time result = new Time(this.hour, this.minute, this.second);
            result.second -= 1;
            if (result.second == -1)
            {
                result.second = 59;
                result.minute -= 1;
                if (result.minute == -1)
                {
                    result.minute = 59;
                    result.hour -= 1;
                }
            }
            return result;
        }
    }
}
