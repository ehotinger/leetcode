public class Solution : Reader4 {
     Buffer store = new Buffer();

    public int Read(char[] buf, int n) {
        if (n == 0) return 0;
        int i = 0;

        // First read off store
        if (store.GetLength() > 0)
        {
            i += store.Read(buf, i, n);
        }

        // Read directly from file in chunks of 4 bytes;
        char[] tmp = new char[4];
        while(n - i > 3)
        {
            int read = Read4(tmp);
            Array.Copy(tmp, 0, buf, i, read);
            i += read;
            if (read < 4)
            {
                // EOF
                return i;
            }
        }

        // Copy left over into buffer
        if (i != n)
        {
            int read = Read4(tmp);
            store.Write(tmp, read);
            i += store.Read(buf, i, n - i);
        }

        return i;        
    }

    class Buffer
    {
        const int SIZE = 4;
        char[] buf = new char[SIZE];
        int start = SIZE, end = SIZE - 1;

        public int Read(char[] dst, int index, int len)
        {
            int copiedLength = Math.Min(len, end - start + 1);
            Array.Copy(buf, start, dst, index, copiedLength);
            start += copiedLength;
            return copiedLength;
        }

        public void Write(char[] src, int len)
        {
            Array.Copy(src, 0, buf, 0, len);
            start = 0;
            end = len - 1;
        }

        public int GetLength()
        {
            return end - start + 1;
        }
    }
}