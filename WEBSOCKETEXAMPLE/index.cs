using UnityEngine;
using System.Collections;
using System.Net.Sockets;

public class UnityToRaspberry : MonoBehaviour {

public string IP = "169.254.242.100"; //
public int Port = 50001;

public byte[] dane = System.Text.Encoding.ASCII.GetBytes("Hello");
public Socket client;

void Start(){
    //dane [0] = 1;

    client = new Socket (AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
    client.Connect (IP, Port);
    if (client.Connected) {
        Debug.Log ("Connected");
    }
    client.Send (dane);
}

void OnApplicationQuit(){
    client.Close();
}



}