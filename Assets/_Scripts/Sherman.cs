using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
//using UnityEngine.Advertisement;

/*
 * ПОКА НЕ ДОПИШУ НЕВНИКАЙТЕ!!
 */
namespace ShermanLibr
{ 
    public class Saver:MonoBehaviour
    {
        #region Serializable Class
        [System.Serializable]
        private class Int
        {
            public int @int;
        }

        [System.Serializable]
        private class String
        {
            public string @string;
        }

        [System.Serializable]
        private class Float
        {
            public float @float;
        }

        [System.Serializable]
        private class Double
        {
            public double @double;
           
        }

        [System.Serializable]
        private class Bool
        {
            public bool @bool;

        }
        #endregion

        #region Method
        public static void Save(int saveInt, string nameKey)
        {
            Int @int = new Int();
            @int.@int = saveInt;

            if (!Directory.Exists(Application.dataPath + "/Saves"))
                Directory.CreateDirectory(Application.dataPath + "/Saves");

            FileStream fs = new FileStream(Application.dataPath + "/Saves/" + nameKey + ".sh", FileMode.Create);

            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(fs, @int);
            fs.Close();
        }

        public static void Load(ref int saveInt, string nameKey)
        {
            if (File.Exists(Application.dataPath + "/Saves/" + nameKey + ".sh"))
            {
                FileStream fs = new FileStream(Application.dataPath + "/Saves/" + nameKey + ".sh", FileMode.Open);

                BinaryFormatter formatter = new BinaryFormatter();

                try
                {
                    Int @int = (Int)formatter.Deserialize(fs);
                    saveInt = @int.@int;
                }
                catch(System.Exception e)
                {
                    Debug.Log(e.Message);
                }
                finally
                {
                    fs.Close();
                }
            }
            else
            {
                Debug.LogError("Ключа " + nameKey + " не существует");
                Application.Quit();
            }
        }

        public static void Save(float saveFloat, string nameKey)
        {
            Float @float = new Float();
            @float.@float = saveFloat;

            if (!Directory.Exists(Application.dataPath + "/Saves"))
                Directory.CreateDirectory(Application.dataPath + "/Saves");

            FileStream fs = new FileStream(Application.dataPath + "/Saves/" + nameKey + ".sh", FileMode.Create);

            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(fs, @float);
            fs.Close();
        }

        public static void Load(ref float loadFloat, string nameKey)
        {
            if (File.Exists(Application.dataPath + "/Saves/" + nameKey + ".sh"))
            {
                FileStream fs = new FileStream(Application.dataPath + "/Saves/" + nameKey + ".sh", FileMode.Open);

                BinaryFormatter formatter = new BinaryFormatter();

                try
                {
                    Float @float = (Float)formatter.Deserialize(fs);
                    loadFloat = @float.@float;
                }
                catch (System.Exception e)
                {
                    Debug.Log(e.Message);
                }
                finally
                {
                    fs.Close();
                }
            }
            else
            {
                Debug.LogError("Ключа " + nameKey + " не существует");
                Application.Quit();
            }
        }

        public static void Save(double saveDouble, string nameKey)
        {
            Double @double = new Double();
            @double.@double = saveDouble;

            if (!Directory.Exists(Application.dataPath + "/Saves"))
                Directory.CreateDirectory(Application.dataPath + "/Saves");

            FileStream fs = new FileStream(Application.dataPath + "/Saves/" + nameKey + ".sh", FileMode.Create);

            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(fs, @double);
            fs.Close();
        }

        public static void Load(ref double loadDouble, string nameKey)
        {
            if (File.Exists(Application.dataPath + "/Saves/" + nameKey + ".sh"))
            {
                FileStream fs = new FileStream(Application.dataPath + "/Saves/" + nameKey + ".sh", FileMode.Open);

                BinaryFormatter formatter = new BinaryFormatter();

                try
                {
                    Double @double = (Double)formatter.Deserialize(fs);
                    loadDouble = @double.@double;
                }
                catch (System.Exception e)
                {
                    Debug.Log(e.Message);
                }
                finally
                {
                    fs.Close();
                }
            }
            else
            {
                Debug.LogError("Ключа " + nameKey + " не существует");
                Application.Quit();
            }
        }

        public static void Save(string saveString, string nameKey)
        {
            String @string = new String();
            @string.@string = saveString;

            if (!Directory.Exists(Application.dataPath + "/Saves"))
                Directory.CreateDirectory(Application.dataPath + "/Saves");

            FileStream fs = new FileStream(Application.dataPath + "/Saves/" + nameKey + ".sh", FileMode.Create);

            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(fs, @string);
            fs.Close();
        }

        public static void Load(ref string loadString, string nameKey)
        {
            if (File.Exists(Application.dataPath + "/Saves/" + nameKey + ".sh"))
            {
                FileStream fs = new FileStream(Application.dataPath + "/Saves/" + nameKey + ".sh", FileMode.Open);

                BinaryFormatter formatter = new BinaryFormatter();

                try
                {
                    String @string = (String)formatter.Deserialize(fs);
                    loadString = @string.@string;
                }
                catch (System.Exception e)
                {
                    Debug.Log(e.Message);
                }
                finally
                {
                    fs.Close();
                }
            }
            else
            {
                Debug.LogError("Ключа " + nameKey + " не существует");
                Application.Quit();
            }
        }

        public static void Save(bool saveBool, string nameKey)
        {
            Bool @bool = new Bool();
            @bool.@bool = saveBool;

            if (!Directory.Exists(Application.dataPath + "/Saves"))
                Directory.CreateDirectory(Application.dataPath + "/Saves");

            FileStream fs = new FileStream(Application.dataPath + "/Saves/" + nameKey + ".sh", FileMode.Create);

            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(fs, @bool);
            fs.Close();
        }

        public static void Load(ref bool loadString, string nameKey)
        {
            if (File.Exists(Application.dataPath + "/Saves/" + nameKey + ".sh"))
            {
                FileStream fs = new FileStream(Application.dataPath + "/Saves/" + nameKey + ".sh", FileMode.Open);

                BinaryFormatter formatter = new BinaryFormatter();

                try
                {
                    Bool @bool = (Bool)formatter.Deserialize(fs);
                    loadString = @bool.@bool;
                }
                catch (System.Exception e)
                {
                    Debug.Log(e.Message);
                }
                finally
                {
                    fs.Close();
                }
            }
            else
            {
                Debug.LogError("Ключа " + nameKey + " не существует");
                Application.Quit();
            }
        }
        #endregion
    }

    /*public class AD
    {
        public static bool isPlayed = Advertisement.isShowing;
        public static void Inicial(string GameId)
        {
            Advertisement.Initialize(GameId);
        }

        public static void ShowAd(string IdAdd)
        {
            if(Advertisement.isInitialized)
                Advertisement.Show(IdAdd);
        }
    }*/

    public class Time:MonoBehaviour
    {
        public static float Hourses, Minutes, Seconds;

        public float TimerF=0;
        public bool Timer=true;
        public bool Stop = false;
        private float time;
        private bool play = true;


        public void StopwatchPlay()
        {
            if (play)
            {
                time+=UnityEngine.Time.deltaTime;
                Seconds = time % 60;
                Minutes = time / 60;
                Hourses = time / 3600;
            }
        }


        public void StopTimer()
        {
            StopAllCoroutines();
        }

        public IEnumerator TimerStart(float time)
        {
            TimerF = 0;
            Timer = true;
            while (time != -1)
            {
                if (Stop)
                {
                    Debug.Log("Stop");
                    Stop = false;
                    yield return null;
                }
                Debug.Log(time);
                TimerF = time--;
                yield return new WaitForSeconds(1);
            }
            Debug.Log("Finish");
            Timer = false;

        }


        public void StopwatchStop()
        {
            play = false;
        }

        public void StopwatchReset()
        {
            time = 0;
        }

        public string ToStringTimer()
        {
            string tim;
            tim = string.Format("{00}", (int)TimerF);
            return tim;
        }

        public override string ToString()
        {
            string tim;
            tim = string.Format("{0:00}:{1:00}", (int)Minutes, (int)Seconds);
            return tim;
        }
    }

    public class Platform
    {
        public static bool PC, Android, IOS;
        
        public static string ReturnPlatform()
        {
#if UNITY_STANDALONE
            PC = true;
            Debug.Log("Windows");
            return "Windows";
#elif UNITY_ANDROID
            Android=true;
            Debug.Log("Andorid");
            return "Android";
#elif UNITY_IOS
            IOS=true;
            Debug.Log("IOS");
            return "IOS";
#endif
        }

    }

    public class ScoreSystem : MonoBehaviour
    {

        public static float Score=0;
        public static float MaxScore=0;

        public static void Inicial()
        {
            Score = 0;
            if (PlayerPrefs.HasKey("MaxScore"))
                MaxScore = PlayerPrefs.GetFloat("MaxScore");
            else MaxScore = 0;
        }


        public static void PlusScore()
        {
            Score++;
        }

        public static void UpdateMaxScore()
        {
            if (MaxScore < Score)
                MaxScore = Score;
        }

        public static void Save()
        {
            PlayerPrefs.SetFloat("MaxScore", MaxScore);
        }
    }

    public class Colors
    {
        public static Color32 RandomColor()
        {
            Color32 randColor = new Color32();
            randColor.r = (byte)Random.Range(0, 255);
            randColor.g = (byte)Random.Range(0, 255);
            randColor.b = (byte)Random.Range(0, 255);
            randColor.a = 255;
            return randColor;
        }

        public static Color32 PohozhColor(Color32 inputColor, byte procent=10)
        {
            Color32 color=new Color32(0,0,0,255);

            byte p = (byte)(255 / 100 * procent);
            byte buf = (byte)Random.Range(-p, p);
            if ((inputColor.r - p + buf) > 0 || (inputColor.r - p - buf) > 0)
            {
                color.r = 0;
                Debug.Log("111");
            }                
            else if ((inputColor.r - p + buf) < 255 || (inputColor.r - p - buf) < 255)
            {
                color.r = 255;
                Debug.Log("222");
            }
            else color.r = (byte)((inputColor.r - p) + Random.Range(-p, p));

            color.g = (byte)((inputColor.g - 0) + Random.Range(-0, 0));
            color.b = (byte)((inputColor.b - 0) + Random.Range(-0, 0));

            return color;
        }
    }


}
