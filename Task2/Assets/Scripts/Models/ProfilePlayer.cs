using AnalyticsTools;
using Models.Tools;
using Profile;

namespace Models
{
    public class ProfilePlayer
    {
        public ProfilePlayer(float speedCar, AdsTools adsTools)
        {
            CurrentState = new SubscriptionProperty<GameState>();
            CurrentCar = new Car(speedCar);
            AnalyticsTools = new AnalyticsTools.AnalyticsTools();
            AdsShower = adsTools;
        }

        public SubscriptionProperty<GameState> CurrentState { get; }

        public Car CurrentCar { get; }

        public IAnalyticsTools AnalyticsTools { get; }
        
        public IAdsShower AdsShower { get; }
    }
}