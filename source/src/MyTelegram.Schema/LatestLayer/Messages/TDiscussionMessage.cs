﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema.Messages;

///<summary>
/// Information about a <a href="https://corefork.telegram.org/api/threads">message thread</a>
/// See <a href="https://corefork.telegram.org/constructor/messages.discussionMessage" />
///</summary>
[TlObject(0xa6341782)]
public sealed class TDiscussionMessage : IDiscussionMessage
{
    public uint ConstructorId => 0xa6341782;
    ///<summary>
    /// Flags, see <a href="https://corefork.telegram.org/mtproto/TL-combinators#conditional-fields">TL conditional fields</a>
    ///</summary>
    public BitArray Flags { get; set; } = new BitArray(32);

    ///<summary>
    /// Discussion messages
    ///</summary>
    public TVector<MyTelegram.Schema.IMessage> Messages { get; set; }

    ///<summary>
    /// Message ID of latest reply in this <a href="https://corefork.telegram.org/api/threads">thread</a>
    ///</summary>
    public int? MaxId { get; set; }

    ///<summary>
    /// Message ID of latest read incoming message in this <a href="https://corefork.telegram.org/api/threads">thread</a>
    ///</summary>
    public int? ReadInboxMaxId { get; set; }

    ///<summary>
    /// Message ID of latest read outgoing message in this <a href="https://corefork.telegram.org/api/threads">thread</a>
    ///</summary>
    public int? ReadOutboxMaxId { get; set; }

    ///<summary>
    /// Number of unread messages
    ///</summary>
    public int UnreadCount { get; set; }

    ///<summary>
    /// Chats mentioned in constructor
    ///</summary>
    public TVector<MyTelegram.Schema.IChat> Chats { get; set; }

    ///<summary>
    /// Users mentioned in constructor
    ///</summary>
    public TVector<MyTelegram.Schema.IUser> Users { get; set; }

    public void ComputeFlag()
    {
        if (/*MaxId != 0 && */MaxId.HasValue) { Flags[0] = true; }
        if (/*ReadInboxMaxId != 0 && */ReadInboxMaxId.HasValue) { Flags[1] = true; }
        if (/*ReadOutboxMaxId != 0 && */ReadOutboxMaxId.HasValue) { Flags[2] = true; }

    }

    public void Serialize(IBufferWriter<byte> writer)
    {
        ComputeFlag();
        writer.Write(ConstructorId);
        writer.Write(Flags);
        writer.Write(Messages);
        if (Flags[0]) { writer.Write(MaxId.Value); }
        if (Flags[1]) { writer.Write(ReadInboxMaxId.Value); }
        if (Flags[2]) { writer.Write(ReadOutboxMaxId.Value); }
        writer.Write(UnreadCount);
        writer.Write(Chats);
        writer.Write(Users);
    }

    public void Deserialize(ref SequenceReader<byte> reader)
    {
        Flags = reader.ReadBitArray();
        Messages = reader.Read<TVector<MyTelegram.Schema.IMessage>>();
        if (Flags[0]) { MaxId = reader.ReadInt32(); }
        if (Flags[1]) { ReadInboxMaxId = reader.ReadInt32(); }
        if (Flags[2]) { ReadOutboxMaxId = reader.ReadInt32(); }
        UnreadCount = reader.ReadInt32();
        Chats = reader.Read<TVector<MyTelegram.Schema.IChat>>();
        Users = reader.Read<TVector<MyTelegram.Schema.IUser>>();
    }
}