using System.Net.WebSockets;
using System.Reflection.PortableExecutable;
using System.Text;

/* Källor:
1. https://learn.microsoft.com/en-us/dotnet/standard/io/how-to-open-and-append-to-a-log-file
2. https://learn.microsoft.com/en-us/dotnet/standard/io/how-to-write-text-to-a-file
3. https://learn.microsoft.com/en-us/dotnet/fundamentals/runtime-libraries/system-datetime#assign-a-computed-value
*/

/* Att Göra

    user = <ditt namn> när du skickar meddelande
    user = echo när du tar emot meddelande från echo-servern
    logfilens namn ska vara chat.log

    * Implementera funktionen log
    * Implementera handleMessage (båda funktions-kroppen och -huvud)
        - Skriver ut det mottagna meddelandet till konsolen.
        - Anropar log-funktionen med lämplig parametrar.
    * Modifiera Main
        - Anropa handleMessage i samband med att meddelande skickats och tas emot.
    
*/
class WebSocketClient
{
<<<<<<< HEAD
    static void HandleMessage(string msg, string user){
        StreamWriter tjenawriter = File.AppendText("chat.log");
        Console.WriteLine(msg);
        log(msg, user, tjenawriter);
        tjenawriter.Close();
        // funktionen saknar både funktionskropp och funktionshuvud (dvs nödvändiga parametrar)
    }
    static void log(string msg,string user,StreamWriter w){
         w.WriteLine($"{DateTime.Now.ToLongTimeString()} {user} | {msg}");

    static void handleMessage(string msg, string user){
        StreamWriter writer = File.AppendText("chat.log");
        Console.WriteLine(msg);
        log(msg,user, writer);
        writer.Close();
        // funktionen saknar både funktionskropp och funktionshuvud (dvs nödvändiga parametrar)
    }
    static void log(string msg,string user,StreamWriter w){
        w.WriteLine($"{DateTime.Now.ToLongTimeString()} {user} | {msg}");
        
>>>>>>> 289843385eaf79cde6cf419e3b3f9148bda43d38
        // Funktionen ska skriva: <nuvarande klockslag> <user> | <msg> till en logfil som definieras av w.
        // Se exempel i filen log.example
    }
    static async Task Send(ClientWebSocket client){
        Console.WriteLine("Skriv in ett meddelande att skicka:");
        string message = Console.ReadLine();
<<<<<<< HEAD
        HandleMessage(message, "goblin");
=======
        handleMessage(message,"Leo");
>>>>>>> 289843385eaf79cde6cf419e3b3f9148bda43d38
        byte[] buffer = Encoding.UTF8.GetBytes(message);
        await client.SendAsync(new ArraySegment<byte>(buffer), WebSocketMessageType.Text, true, CancellationToken.None);
    }
    public static async Task Main()
    {
        string serverUri = "wss://echo.websocket.org";
        ClientWebSocket client = new ClientWebSocket();
        await client.ConnectAsync(new Uri(serverUri), CancellationToken.None);
        byte[] receiveBuffer = new byte[1024];
        while (client.State == WebSocketState.Open)
        {
            WebSocketReceiveResult result = await client.ReceiveAsync(new ArraySegment<byte>(receiveBuffer), CancellationToken.None);
            Console.Clear();
            if (result.MessageType == WebSocketMessageType.Text)
            {
                string receivedMessage = Encoding.UTF8.GetString(receiveBuffer, 0, result.Count);
<<<<<<< HEAD
                HandleMessage(receivedMessage,"echo");
                await Send(client);
                
                
=======
                handleMessage(receivedMessage,"echo");
                await Send(client);
                
>>>>>>> 289843385eaf79cde6cf419e3b3f9148bda43d38
            }
        }
    }
}