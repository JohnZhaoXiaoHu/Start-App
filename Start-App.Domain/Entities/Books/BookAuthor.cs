﻿/*
 * Copyright(c) Trickyrat All Rights Reserved.
 * Licensed under the MIT LICENSE.
 */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Start_App.Domain.Entities.Books
{
    public class BookAuthor
    {
        public Guid BookId { get; set; }
        public Book Book { get; set; }

        public Guid AuthorId { get; set; }
        public Author Author { get; set; }
    }
}
