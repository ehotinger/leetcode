// https://leetcode.com/problems/encode-and-decode-tinyurl/
public class Codec {

    private Dictionary<int, string> map = new Dictionary<int, string>();
    // Encodes a URL to a shortened URL
    public string encode(string longUrl) {
        var hash = longUrl.GetHashCode();
        map[hash] = longUrl;
        return $"http://tinyurl.com/{hash}";
    }

    // Decodes a shortened URL to its original URL.
    public string decode(string shortUrl) {
        return map[int.Parse(shortUrl.Replace("http://tinyurl.com/", ""))];
    }
}

// Your Codec object will be instantiated and called as such:
// Codec codec = new Codec();
// codec.decode(codec.encode(url));