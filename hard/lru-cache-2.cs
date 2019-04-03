using System;
using System.Collections;
using System.Collections.Generic;

class Solution
{
    static void Main(string[] args)
    {
        var cache = new LRUCache(2);
        var images = new List<Image>() {
            new Image{Name="foo", Value="fooval"},
            new Image{Name="bar", Value="barval"},
            new Image{Name="qux", Value= "quxval"},
        };
        
        foreach(var image in images ) {
            var lookup = cache.GetImage(image.Name);
            Console.WriteLine(lookup);
            cache.SetImage(image.Name, image);
            lookup = cache.GetImage(image.Name);
            Console.WriteLine(lookup);
        }
        
        //Console.WriteLine(cache.Count());
        //Console.WriteLine(cache.CacheCount());
        cache.Print();
    }
}

public class LRUCache {
    private int _capacity;
    
    private readonly LinkedList<Image> _list;
    private readonly Dictionary<string, LinkedListNode<Image>> _cache;
    
    public LRUCache(int capacity) {
        _capacity = capacity - 1;
        if (_capacity <= 0) throw new ArgumentException("can't have <= 0 capacity");
        
        _cache = new Dictionary<string, LinkedListNode<Image>>(); 
        _list  = new LinkedList<Image>();
    }
    
    public int Count() {
        return _list.Count;   
    }
    
    public int CacheCount() {
        return _cache.Count;   
    }
    
    public void Print() {
        foreach(var item in _list) {
            Console.WriteLine($"ListItem: {item.Value}, Cache: {_cache[item.Name]}");   
        }
    }
    
    public Image GetImage(string key) {
        if (!_cache.ContainsKey(key)) {
            var imgLookup = Service.GetImage(key);
            SetImage(key, imgLookup);
            return imgLookup;
        }
        _list.Remove(_cache[key]);
        _list.AddLast(_cache[key]);
        return _cache[key].Value;
    }
    
    
    public void SetImage(string key, Image val) {
        if (_cache.ContainsKey(key)) {
            _cache[key].Value = val;
            _list.Remove(_cache[key]);
            _list.AddLast(_cache[key]);
            return;
        }
        Console.WriteLine($"SetImage: {_cache.Count}");
        
        if(_cache.Count > _capacity) {
            Console.WriteLine("removing...");
            _cache.Remove(_list.First.Value.Name);
            _list.RemoveFirst();
        }
        
        _cache.Add(key, new LinkedListNode<Image>(val));
        _list.AddLast(_cache[key]);
    }
    
    public int GetCapacity(){
        return _capacity;
    }
}

public class Image {
    public string Name {get; set;}
    public string Value {get; set;}
    
    public override string ToString() {
        return $"Name: {Name} Value: {Value}";
    }
}

public static class Service {
    public static Image GetImage(string key) {
        return new Image { Name=key, Value = key + "fromService"};
    }
}