﻿namespace Core.Entities
{
    public class QRCodeImage
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public byte[] Image { get; set; }
    }
}
