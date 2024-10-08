﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetroTicket.Entities.Models
{
    public class Result<T>
    {
        public bool IsSuccess { get; private set; }
        public string? ErrorMessage { get; private set; }
        public T? Data { get; private set; }

        private Result(bool isSuccess, string? errorMessage, T? data)
        {
            IsSuccess = isSuccess;
            ErrorMessage = errorMessage;
            Data = data;
        }

        // Factory method for success
        public static Result<T> Success(T data)
        {
            return new Result<T>(true, null, data);
        }

        // Factory method for failure
        public static Result<T> Failure(string errorMessage)
        {
            return new Result<T>(false, errorMessage, default(T));
        }
    }
}
