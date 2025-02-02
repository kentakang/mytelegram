﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema.Messages;

///<summary>
/// Indicate to the server (from the user side) that the user is still using a web app.If the method returns a <code>QUERY_ID_INVALID</code> error, the webview must be closed.
/// See <a href="https://corefork.telegram.org/method/messages.prolongWebView" />
///</summary>
[TlObject(0xb0d81a83)]
public sealed class RequestProlongWebView : IRequest<IBool>
{
    public uint ConstructorId => 0xb0d81a83;
    ///<summary>
    /// Flags, see <a href="https://corefork.telegram.org/mtproto/TL-combinators#conditional-fields">TL conditional fields</a>
    ///</summary>
    public BitArray Flags { get; set; } = new BitArray(32);

    ///<summary>
    /// Whether the inline message that will be sent by the bot on behalf of the user once the web app interaction is <a href="https://corefork.telegram.org/method/messages.sendWebViewResultMessage">terminated</a> should be sent silently (no notifications for the receivers).
    /// See <a href="https://corefork.telegram.org/type/true" />
    ///</summary>
    public bool Silent { get; set; }

    ///<summary>
    /// Dialog where the web app was opened.
    /// See <a href="https://corefork.telegram.org/type/InputPeer" />
    ///</summary>
    public MyTelegram.Schema.IInputPeer Peer { get; set; }

    ///<summary>
    /// Bot that owns the <a href="https://corefork.telegram.org/api/bots/webapps">web app</a>
    /// See <a href="https://corefork.telegram.org/type/InputUser" />
    ///</summary>
    public MyTelegram.Schema.IInputUser Bot { get; set; }

    ///<summary>
    /// Web app interaction ID obtained from <a href="https://corefork.telegram.org/method/messages.requestWebView">messages.requestWebView</a>
    ///</summary>
    public long QueryId { get; set; }
    public MyTelegram.Schema.IInputReplyTo? ReplyTo { get; set; }

    ///<summary>
    /// Open the web app as the specified peer
    /// See <a href="https://corefork.telegram.org/type/InputPeer" />
    ///</summary>
    public MyTelegram.Schema.IInputPeer? SendAs { get; set; }

    public void ComputeFlag()
    {
        if (Silent) { Flags[5] = true; }
        if (ReplyTo != null) { Flags[0] = true; }
        if (SendAs != null) { Flags[13] = true; }
    }

    public void Serialize(IBufferWriter<byte> writer)
    {
        ComputeFlag();
        writer.Write(ConstructorId);
        writer.Write(Flags);
        writer.Write(Peer);
        writer.Write(Bot);
        writer.Write(QueryId);
        if (Flags[0]) { writer.Write(ReplyTo); }
        if (Flags[13]) { writer.Write(SendAs); }
    }

    public void Deserialize(ref SequenceReader<byte> reader)
    {
        Flags = reader.ReadBitArray();
        if (Flags[5]) { Silent = true; }
        Peer = reader.Read<MyTelegram.Schema.IInputPeer>();
        Bot = reader.Read<MyTelegram.Schema.IInputUser>();
        QueryId = reader.ReadInt64();
        if (Flags[0]) { ReplyTo = reader.Read<MyTelegram.Schema.IInputReplyTo>(); }
        if (Flags[13]) { SendAs = reader.Read<MyTelegram.Schema.IInputPeer>(); }
    }
}
