public class LRUCache{
    private class LRUCacheItem{
        public int CacheKey { get; set; }
        public int CacheValue { get; set; }
    }
    
    // Caution here: in the Dictionary, LinkedListNode here is faster than LRUCacheItem
    private Dictionary<int, LinkedListNode<LRUCacheItem>> cacheMap = new Dictionary<int, LinkedListNode<LRUCacheItem>>();
    private LinkedList<LRUCacheItem> lruList = new LinkedList<LRUCacheItem>();
    private int capacity;
    public LRUCache(int capacity) { this.capacity = capacity;}
    public int Get(int key){
        if (!cacheMap.ContainsKey(key)) return -1;
        lruList.Remove(cacheMap[key]);
        lruList.AddLast(cacheMap[key]);
        return cacheMap[key].Value.CacheValue;
    }
    public void Set(int key, int val){
        if (cacheMap.ContainsKey(key)){
            cacheMap[key].Value.CacheValue = val;
            lruList.Remove(cacheMap[key]);
            lruList.AddLast(cacheMap[key]);
            return;
        }
        if (cacheMap.Count >= capacity){
            cacheMap.Remove(lruList.First.Value.CacheKey);
            lruList.RemoveFirst();
        }
        cacheMap.Add(key, new LinkedListNode<LRUCacheItem>(new LRUCacheItem { CacheKey = key, CacheValue = val }));
        lruList.AddLast(cacheMap[key]);
    }
}