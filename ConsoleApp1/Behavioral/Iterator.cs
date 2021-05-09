using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsCSharp.Behavioral
{
    // It presents a way to access the elements of an object without exposing the underlying presentation
    /*
     * In object-oriented programming,
     * the iterator pattern is a design pattern in which an iterator is used to traverse a container and access
     * the container's elements. The iterator pattern decouples algorithms from containers;
     * in some cases, algorithms are necessarily container-specific and thus cannot be decoupled.
     */
    class RadioStation
    {
        protected float frequency;

        public RadioStation(float frequency)
        {
            this.frequency = frequency;
        }
        public float getFrequency() => this.frequency;
    }

    // Then we have our iterator
    // use Countable;
    // use Iterator;

    class StationList : Iterator
    {
        private List<RadioStation> Stations = new List<RadioStation>();
        private int Counter;

        public void AddStation(RadioStation station) => this.Stations.Add(station);
        public void RemoveStation(RadioStation toRemove)=> this.Stations.Remove(toRemove);
        
        public int Count() => this.Stations.Count ;
        public RadioStation Current() =>  this.Stations[this.Counter];
        public int Key()=> this.Counter; 
        public void Next()=> this.Counter++ ;
        public void Rewind() => this.Counter = 0;
        public bool valid() => this.Stations is null;
    }
     class Iterator
     {
        // static void Main(string[] args)
        //    {
        //    var stationList = new StationList();
        //         stationList.AddStation(new RadioStation(89));
        //         stationList.AddStation(new RadioStation(101));
        //         stationList.AddStation(new RadioStation(102));
        //         stationList.AddStation(new RadioStation(103.2f));
        //        for (int i = 0; i < stationList.Count(); i++)
        //        {
        //            Console.WriteLine(stationList.Current().getFrequency());
        //            stationList.Next();

        //        }

        //    stationList.RemoveStation(new RadioStation(89)); // Will remove station 89
        //}

     }
}
