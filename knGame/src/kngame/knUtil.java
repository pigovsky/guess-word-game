//Автор(с): Кудуштеев Алексей
package kngame;
import java.io.FileInputStream;
import java.io.FileOutputStream;


final class knCyrillic {
	public final static char PUNCT_N_CHAR = 0x2116;
	public final static byte PUNCT_N_BYTE = 67;

	public final static char FIRST_UPPER_CHAR = 0x410;
	public final static char LAST_UPPER_CHAR  = 0x42F;
	public final static char NS_UPPER_CHAR    = 0x401;

	public final static char FIRST_LOWER_CHAR = 0x430;
	public final static char LAST_LOWER_CHAR  = 0x44F;
	public final static char NS_LOWER_CHAR    = 0x451;

        public final static byte FIRST_UPPER_BYTE = 0;
	public final static byte LAST_UPPER_BYTE  = 31;

	public final static byte FIRST_LOWER_BYTE = 33;
	public final static byte LAST_LOWER_BYTE  = 65;

	public final static byte NS_UPPER = 32;
	public final static byte NS_LOWER = 66;

	public final static int CH_SPLIT = 33;
}

//байтовый массив
final class ByteChars {
	private final static int MAX_LEN = 64;
	private byte[] arr = null;
	private int    cnt = 0;
	private int    max = 0;

	public ByteChars(){
		arr = new byte[MAX_LEN];
		cnt = 0;
		max = MAX_LEN;
	}

	//добавить строку
	public void write(String s){
		int n = s.length();
		if((cnt + n) >= max)
			realloc(n);

		int c;
		for(int i = 0; i < n; ++i){
			c = s.charAt(i);
			if(c <= 0x007F)
				arr[cnt++] = (byte)c;
			else if(c >= knCyrillic.FIRST_UPPER_CHAR && c <= knCyrillic.LAST_UPPER_CHAR)
				arr[cnt++] = (byte)-(c - knCyrillic.FIRST_UPPER_CHAR);
			else if(c == knCyrillic.NS_UPPER_CHAR)
				arr[cnt++] = -knCyrillic.NS_UPPER;
			else if(c >= knCyrillic.FIRST_LOWER_CHAR && c <= knCyrillic.LAST_LOWER_CHAR)
				arr[cnt++] = (byte)-(c - knCyrillic.FIRST_LOWER_CHAR + knCyrillic.CH_SPLIT);
			else if(c == knCyrillic.NS_LOWER_CHAR)
				arr[cnt++] = -knCyrillic.NS_LOWER;
			else if(c == knCyrillic.PUNCT_N_CHAR)
				arr[cnt++] = -knCyrillic.PUNCT_N_BYTE;
			else
				arr[cnt++] = 0x7F;
		}
	}

	//добавить символ
	public void write(char c){
		if((cnt + 1) >= max)
			realloc(1);

		if(c <= 0x007F)
			arr[cnt++] = (byte)c;
		else if(c >= knCyrillic.FIRST_UPPER_CHAR && c <= knCyrillic.LAST_UPPER_CHAR)
			arr[cnt++] = (byte)-(c - knCyrillic.FIRST_UPPER_CHAR);
		else if(c == knCyrillic.NS_UPPER_CHAR)
			arr[cnt++] = -knCyrillic.NS_UPPER;
		else if(c >= knCyrillic.FIRST_LOWER_CHAR && c <= knCyrillic.LAST_LOWER_CHAR)
			arr[cnt++] = (byte)-(c - knCyrillic.FIRST_LOWER_CHAR + knCyrillic.CH_SPLIT);
		else if(c == knCyrillic.NS_LOWER_CHAR)
			arr[cnt++] = -knCyrillic.NS_LOWER;
		else if(c == knCyrillic.PUNCT_N_CHAR)
			arr[cnt++] = -knCyrillic.PUNCT_N_BYTE;
		else
			arr[cnt++] = 0x7F;
	}

	//добавить число
	public void write(int num){
		int n = count_ds(num);
		if((cnt + n) >= max)
			realloc(n);

		int pos = cnt;
		do {
			arr[cnt++] = (byte)(num % 10 + '0');
		} while((num /= 10) != 0);

		byte t;
		for(int i = cnt - 1; pos < i; ++pos, --i){
			t        = arr[i];
			arr[i]   = arr[pos];
			arr[pos] = t;
		}
	}

	//добавить байтовый массив
	public void write(byte[] src, int num){
		if((cnt + num) >= max)
			realloc(num);

		System.arraycopy(src, 0, arr, cnt, num);
		cnt += num;
	}

	//добавить  args ? va_list
	public void write(Object ...args){
		for(int i = 0; i < args.length; ++i){
			if(args[i] instanceof Character)
				write((Character)args[i]);
			else if(args[i] instanceof Integer)
				write((Integer)args[i]);
			else if(args[i] instanceof String)
				write((String)args[i]);
		}
	}

	//прочитать в строку от first до last
	public void read(int first, int last, StringBuilder sb){
		if((first >= last) || (last > cnt))
			return;

		if(sb.length() > 0)
			sb.delete(0, sb.length());

		byte c = 0;
		for(int i = first; i < last; ++i){
			if(arr[i] > 0){
				sb.append((char)arr[i]);
				continue;
			}
			c = (byte)(-arr[i]);

			if(c >= knCyrillic.FIRST_UPPER_BYTE && c <= knCyrillic.LAST_UPPER_BYTE)
				sb.append((char)(knCyrillic.FIRST_UPPER_CHAR + c));
			else if(c == knCyrillic.NS_UPPER)
				sb.append(knCyrillic.NS_UPPER_CHAR);
			else if(c >= knCyrillic.FIRST_LOWER_BYTE && c <= knCyrillic.LAST_LOWER_BYTE)
				sb.append((char)(knCyrillic.FIRST_LOWER_CHAR + (c - knCyrillic.CH_SPLIT)));
			else if(c == knCyrillic.NS_LOWER)
				sb.append(knCyrillic.NS_LOWER_CHAR);
			else if(c == knCyrillic.PUNCT_N_BYTE)
				sb.append(knCyrillic.PUNCT_N_CHAR);
		}
	}

	public void read(StringBuilder sb){
		read(0, cnt, sb);
	}

	//вернуть подстроку
	public String substr(int first, int last){
		if((first >= last) || (last > cnt))
			return null;

		String s = "";
		byte   c = 0;
		for(int i = first; i < last; ++i){
			if(arr[i] > 0){
				s += (char)arr[i];
				continue;
			}
			c = (byte)(-arr[i]);

			if(c >= knCyrillic.FIRST_UPPER_BYTE && c <= knCyrillic.LAST_UPPER_BYTE)
				s += (char)(knCyrillic.FIRST_UPPER_CHAR + c);
			else if(c == knCyrillic.NS_UPPER)
				s += knCyrillic.NS_UPPER_CHAR;
			else if(c >= knCyrillic.FIRST_LOWER_BYTE && c <= knCyrillic.LAST_LOWER_BYTE)
				s += (char)(knCyrillic.FIRST_LOWER_CHAR + (c - knCyrillic.CH_SPLIT));
			else if(c == knCyrillic.NS_LOWER)
				s += knCyrillic.NS_LOWER_CHAR;
			else if(c == knCyrillic.PUNCT_N_BYTE)
				s += knCyrillic.PUNCT_N_CHAR;
		}
		return s;
	}

	//удаление от first до last
	public void remove(int first, int last){
		if((first < last) && (last <= cnt)){
			cnt -= last - first;
			System.arraycopy(arr, last, arr, first, cnt);
		}
	}

	//удаление левой части строки от pos
	public void remove_left(int pos){
		if(pos < cnt){
			System.arraycopy(arr, pos, arr, 0, cnt - pos);
			cnt -= pos;
		} else if(pos >= cnt)
			cnt = 0;
	}

	public byte getAt(int index){
		return arr[index];
	}

	public void reset(){
		cnt = 0;
	}

	public void dispose(){
		arr = null;
		cnt = max = 0;
	}

	public byte[] getData(){
		return arr;
	}

	public int getCount(){
		return cnt;
	}

	public String getText(){
		return (cnt > 0) ? new String(arr, 0, cnt) : null;
	}

	private void realloc(int n){
		int    len = max + n + max / 2;
		byte[] tmp = new byte[len];
		System.arraycopy(arr, 0, tmp, 0, cnt);
		arr = null;
		arr = tmp;
		max = len;
	}

	private int count_ds(int num){
		int n = 0;
		do {
			++n;
		} while((n /= 10) != 0);
		return n;
	}
}


//----------------------------------------------------------------------------------------------------------------------------------------
/* формат блока данных в кодировке ascii
	{
		name:"string"  строка
                name:integer   целое число
		name:char      символ
		name:float     вещественное число одинарной точности
	}
*/
final class kv_parser {
	private final static int  MAX_SIZE  = 524288; //1-MB
	private final static char CH_BEGIN  = '{';
	private final static char CH_END    = '}';
	private final static char CH_STRING = '"';
	private final static char CH_DELIM  = ':';

	private final ByteChars sb = new ByteChars();
	private int   first = 0, last = 0;

	public void add(byte[] arr, int num){
		prolog_detect();
		sb.write(arr, num);
		epilog_detect();
	}

	public void add(String s){
		prolog_detect();
		sb.write(s);
		epilog_detect();
	}

	public void add(Object ...args){
		prolog_detect();
		sb.write(args);
		epilog_detect();
	}

	public int getInt(String key){
		if(last == 0)
			return 0;

		byte[] arr = sb.getData();
		int      v = 0, pos = sb_findKey(key);
		if(pos != -1){
			boolean neg = (arr[pos] == '-');
			if(neg)
				++pos;

			while((pos < last) && Character.isDigit(arr[pos]))
				v = v*10 + (int)(arr[pos++] - '0');

			if(neg)
				v = 0 - v;
		}
		return v;
	}

	public float getFloat(String key){
		if(last == 0)
			return 0.0f;

		float    v = 0.0f;
		byte[] arr = sb.getData();
		int    pos = sb_findKey(key);
		if(pos != -1){
			boolean neg = (arr[pos] == '-');
			if(neg)
				++pos;

			int a = 0;
			while((pos < last) && Character.isDigit(arr[pos]))
				a = a*10 + (int)(arr[pos++] - '0');

			v = (float)a;
			if((pos < last) && (arr[pos] == '.')){
				float m = 1.0f;
				for(++pos, a = 0; (pos < last) && Character.isDigit(arr[pos]); ++pos){
					a  = a*10 + (int)(arr[pos] - '0');
					m *= 0.1f;
				}

				if(a > 0)
					v += m * (float)a;
			}

			if(neg)
				v = 0.0f - v;
		}
		return v;
	}

	public char getChar(String key){
		if(last == 0)
			return 0;

		int pos = sb_findKey(key);
		return (pos != -1) ? (char)sb.getAt(pos) : 0;
	}

	public String getString(String key){
		if(last == 0)
			return null;

		String s = null;
		int  pos = sb_findKey(key);
		if((pos != -1) && (sb.getAt(pos) == CH_STRING)){
			int n = s_find_last(++pos);
			if(n != -1)
				s = sb.substr(pos, n);
		}
		return s;
	}

	public boolean getString(String key, StringBuilder str){
		if(last == 0)
			return false;
		if(str.length() > 0)
			str.delete(0, str.length());

		int pos = sb_findKey(key);
		if((pos != -1) && (sb.getAt(pos) == CH_STRING)){
			int n = s_find_last(++pos);
			if(n != -1){
				sb.read(pos, n, str);
				return true;
			}
		}
		return false;
	}

	public boolean isBlockData(){
		return (last > 0);
	}

	public String getBlockData(){
		return (last > 0) ? sb.substr(first, last) : null;
	}

	public ByteChars getByteChars(){
		return sb;
	}

	public void reset(){
		sb.reset();
		first = last = 0;
	}

	public void dispose(){
		sb.dispose();
		first = last = 0;
	}

	private int sb_indexOf(char ch, int pos){
		int      n = sb.getCount();
		byte[] arr = sb.getData();
		char c;
		for(int i = pos; i < n; ++i){
			c = (char)arr[i];
			if(c == CH_STRING){
				++i;
				while((i < n) && (arr[i] != CH_STRING))
					++i;
			} else if(c == ch)
				return i;
		}
		return -1;
	}

	private int sb_findKey(String key){
		int     a, b, n = key.length();
		byte[]  arr = sb.getData();
		boolean res;
		for(int i = first; i < last; ++i){
			if(arr[i] == CH_STRING){
				++i;
				while((i < last) && (arr[i] != CH_STRING))
					++i;
                        } else {
				for(a = i, b = 0; (a < last) && (b < n); ++a, ++b){
					if(arr[a] != key.charAt(b))
						break;
				}

				if(b == n){
					res  = ((i == first) || !Character.isLetterOrDigit(arr[i - 1]));
					res &= (((i + n) < last) && (arr[i + n] == CH_DELIM));
					if(res)
						return i + n + 1;
					i += n - 1;
				}
			}
		}
		return -1;
	}

	private int s_find_last(int pos){
		byte[] arr = sb.getData();
		while(pos < last){
			if(arr[pos] == CH_STRING)
				break;
			++pos;
		}
		return ((pos < last) && (arr[pos] == CH_STRING)) ? pos : -1;
	}

	private void prolog_detect(){
		if(last > 0){
			sb.remove_left(last);
			first = last = 0;
		}

		if(sb.getCount() > MAX_SIZE){
			sb.reset();
			first = last = 0;
		}
	}

	private void epilog_detect(){
		int x = sb_indexOf(CH_BEGIN, 0);
		if(x != -1){
			int y = sb_indexOf(CH_END, x);
			if(y != -1){
				first = x;
				last  = y + 1;
			}
		}
	}
}


//-------------------------------------------------------------------------------------------------------------------------------

//сохранение имя хоста и порт
final class knConfig {
	private static final String file_config = "kn_config.ini";
	public static String host_ip = "localhost";
	public static int       port = 7777;

	//загрузить предыдущие параметры
	public static void load(){
		FileInputStream fp = null;
		byte[] buf = null;
		try {
			fp  = new FileInputStream(file_config);
			buf = new byte[fp.available()];
			fp.read(buf);

			host_ip = "";
			int   i = 0;
			while((i < buf.length) && (buf[i] != '|'))
				host_ip += (char)buf[i++];

			if((i < buf.length) && (buf[i] == '|'))
				++i;

			port = 0;
			while(i < buf.length)
				port = port*10 + (int)(buf[i++] - '0');

		} catch(Exception e){
			//e.printStackTrace();
		} finally {
			if(fp != null){
				try { fp.close(); } catch(Exception p){}
			}
			fp  = null;
                        buf = null;
		}
	}

	//сохранить параметры на будущее
	public static void save(String _host, int _port){
		byte[] ns = { (byte)'|', 0, 0, 0, 0, 0, 0, 0 };
		int    i  = 1;
		do {
			ns[i++] = (byte)((_port % 10) + '0');
		} while((_port /= 10) != 0);

		int n = i, j = 1;
		for(i -= 1; j < i; ++j, --i){
			byte t = ns[i];
			ns[i]  = ns[j];
			ns[j]  = t;
		}

		FileOutputStream fp = null;
		try {
			fp = new FileOutputStream(file_config);
			fp.write(_host.getBytes());
			fp.write(ns, 0, n);
			fp.flush();
		} catch(Exception e){
			//e.printStackTrace();
		} finally {
			if(fp != null){
				try { fp.close(); } catch(Exception p){}
			}
			fp = null;
		}
	}
}

