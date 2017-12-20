﻿// Copyright (c) 2001-2017 Aspose Pty Ltd. All Rights Reserved.
//
// This file is part of Aspose.Words. The source code in this file
// is only intended as a supplement to the documentation, and is provided
// "as is", without warranty of any kind, either expressed or implied.
//////////////////////////////////////////////////////////////////////////

using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using Aspose.Words;
using Aspose.Words.Drawing;
using NUnit.Framework;

namespace ApiExamples
{
    [TestFixture]
    public class ExDocumentBuilderImages : ApiExampleBase
    {
        [Test]
        public void InsertImageStreamRelativePosition()
        {
            //ExStart
            //ExFor:DocumentBuilder.InsertImage(Stream, RelativeHorizontalPosition, Double, RelativeVerticalPosition, Double, Double, Double, WrapType)
            //ExSummary:Shows how to insert an image into a document from a stream, also using relative positions.
            Document doc = new Document();
            DocumentBuilder builder = new DocumentBuilder(doc);

            using (Stream stream = File.OpenRead(ImageDir + "Aspose.Words.gif"))
            {
                builder.InsertImage(stream, RelativeHorizontalPosition.Margin, 100, RelativeVerticalPosition.Margin, 100, 200, 100, WrapType.Square);
            }

            builder.Document.Save(MyDir + @"\Artifacts\Image.CreateFromStreamRelativePosition.doc");
            //ExEnd
        }

        [Test]
        public void InsertImageFromByteArray()
        {
            //ExStart
            //ExFor:DocumentBuilder.InsertImage(Byte[])
            //ExSummary:Shows how to import an image into a document from a byte array.
            Document doc = new Document();
            DocumentBuilder builder = new DocumentBuilder(doc);

            // Prepare a byte array of an image.
            Image image = Image.FromFile(ImageDir + "Aspose.Words.gif");

            using (MemoryStream imageBytes = new MemoryStream())
            {
                image.Save(imageBytes, ImageFormat.Png);

                builder.InsertImage(imageBytes.ToArray());
                builder.Document.Save(MyDir + @"\Artifacts\Image.CreateFromByteArrayDefault.doc");
            }
            //ExEnd
        }

        [Test]
        public void InsertImageFromByteArrayCustomSize()
        {
            //ExStart
            //ExFor:DocumentBuilder.InsertImage(Byte[], Double, Double)
            //ExSummary:Shows how to import an image into a document from a byte array, with a custom size.
            Document doc = new Document();
            DocumentBuilder builder = new DocumentBuilder(doc);

            // Prepare a byte array of an image.
            Image image = Image.FromFile(ImageDir + "Aspose.Words.gif");

            using (MemoryStream imageBytes = new MemoryStream())
            {
                image.Save(imageBytes, ImageFormat.Png);

                builder.InsertImage(imageBytes, ConvertUtil.PixelToPoint(450), ConvertUtil.PixelToPoint(144));
                builder.Document.Save(MyDir + @"\Artifacts\Image.CreateFromByteArrayCustomSize.doc");
            }
            //ExEnd
        }

        [Test]
        public void InsertImageFromByteArrayRelativePosition()
        {
            //ExStart
            //ExFor:DocumentBuilder.InsertImage(Byte[], RelativeHorizontalPosition, Double, RelativeVerticalPosition, Double, Double, Double, WrapType)
            //ExSummary:Shows how to import an image into a document from a byte array, also using relative positions.
            Document doc = new Document();
            DocumentBuilder builder = new DocumentBuilder(doc);

            // Prepare a byte array of an image.
            Image image = Image.FromFile(ImageDir + "Aspose.Words.gif");

            using (MemoryStream imageBytes = new MemoryStream())
            {
                image.Save(imageBytes, ImageFormat.Png);

                builder.InsertImage(imageBytes, RelativeHorizontalPosition.Margin, 100, RelativeVerticalPosition.Margin, 100, 200, 100, WrapType.Square);
                builder.Document.Save(MyDir + @"\Artifacts\Image.CreateFromByteArrayRelativePosition.doc");
            }
            //ExEnd
        }

        [Test]
        public void InsertImageFromImageCustomSize()
        {
            //ExStart
            //ExFor:DocumentBuilder.InsertImage(Image, Double, Double)
            //ExSummary:Shows how to import an image into a document, with a custom size.
            Document doc = new Document();
            DocumentBuilder builder = new DocumentBuilder(doc);

            using (Image rasterImage = Image.FromFile(ImageDir + "Aspose.Words.gif"))
            {
                builder.InsertImage(rasterImage, ConvertUtil.PixelToPoint(450), ConvertUtil.PixelToPoint(144));
                builder.Writeln();
            }

            builder.Document.Save(MyDir + @"\Artifacts\Image.CreateFromImageWithStreamCustomSize.doc");
            //ExEnd
        }

        [Test]
        public void InsertImageFromImageRelativePosition()
        {
            //ExStart
            //ExFor:DocumentBuilder.InsertImage(Image, RelativeHorizontalPosition, Double, RelativeVerticalPosition, Double, Double, Double, WrapType)
            //ExSummary:Shows how to import an image into a document, also using relative positions.
            Document doc = new Document();
            DocumentBuilder builder = new DocumentBuilder(doc);

            using (Image rasterImage = Image.FromFile(ImageDir + "Aspose.Words.gif"))
            {
                builder.InsertImage(rasterImage, RelativeHorizontalPosition.Margin, 100, RelativeVerticalPosition.Margin, 100, 200, 100, WrapType.Square);
            }

            builder.Document.Save(MyDir + @"\Artifacts\Image.CreateFromImageWithStreamRelativePosition.doc");
            //ExEnd
        }

        [Test]
        public void InsertImageStreamCustomSize()
        {
            //ExStart
            //ExFor:DocumentBuilder.InsertImage(Stream, Double, Double)
            //ExSummary:Shows how to import an image from a stream into a document with a custom size.
            Document doc = new Document();
            DocumentBuilder builder = new DocumentBuilder(doc);

            using (Stream stream = File.OpenRead(ImageDir + "Aspose.Words.gif"))
            {
                builder.InsertImage(stream, ConvertUtil.PixelToPoint(400), ConvertUtil.PixelToPoint(400));
            }

            builder.Document.Save(MyDir + @"\Artifacts\Image.CreateFromStreamCustomSize.doc");
            //ExEnd
        }

        [Test]
        public void InsertImageStringCustomSize()
        {
            //ExStart
            //ExFor:DocumentBuilder.InsertImage(String, Double, Double)
            //ExSummary:Shows how to import an image from a url into a document with a custom size.
            Document doc = new Document();
            DocumentBuilder builder = new DocumentBuilder(doc);

            // Remote URI
            builder.InsertImage("http://www.aspose.com/images/aspose-logo.gif", ConvertUtil.PixelToPoint(450), ConvertUtil.PixelToPoint(144));

            // Local URI
            builder.InsertImage(ImageDir + "Aspose.Words.gif", ConvertUtil.PixelToPoint(400), ConvertUtil.PixelToPoint(400));

            doc.Save(MyDir + @"\Artifacts\DocumentBuilder.InsertImageFromUrlCustomSize.doc");
            //ExEnd
        }
    }
}
