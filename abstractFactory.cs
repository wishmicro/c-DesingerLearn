namespace EFCoding
{
    public abstract class Road
    {

    }

    public abstract class Building
    {

    }

    public abstract class Tunnel
    {

    }

    public abstract class Jungle
    {

    }

    public  class ModernRoad : Road 
    {

    }

    public  class ModernBuilding : Building 
    {

    }

    public  class ModernTunnel : Tunnel 
    {

    }

    public  class ModernJungle : Jungle
    {

    }

    // 总接口 抽象接口

    public abstract class FacilitiesFactry
    {
        public abstract Road CreateRoad();

        public abstract Tunnel CreateTunnel();

        public abstract Jungle CreateJungle();

        public abstract Building CreateBuilding();

    }

    public class ModernFacilitiesFactry : FacilitiesFactry
    {
        public override Building CreateBuilding()
        {
            return new ModernBuilding();
        }

        public override Jungle CreateJungle()
        {
            return new ModernJungle();
        }

        public override Road CreateRoad()
        {
            return new ModernRoad();
        }

        public override Tunnel CreateTunnel()
        {
            return new ModernTunnel();
        }
    }


    // 客户程序 尽量让客户端程序这么不要有改动
    class GameManager
    {

        FacilitiesFactry facilities;
        public GameManager(FacilitiesFactry facilitiesFactry)
        {
            this.facilities = facilitiesFactry;
        }

        public void BuildGameFacilities()
        {
            Road road = facilities.CreateRoad();

            Tunnel tunnel = facilities.CreateTunnel();

            Jungle jungle = facilities.CreateJungle();

            Building building = facilities.CreateBuilding();
        }

        public void Play()
        {
            // 把上述创建的对象进行一个实现 。它没有具体实例类


        }


    }

}
