# Introduction
This repo forked for research purposes and check if **Arabic Docs** can be OCRed with high quality results.

I tried to use the built-in implementation for Tesseract 3.05 and 4.0
3.05 => Works well
4.0 => Not working!

PDF Arabic Document downloaded from the internet and the 

## How did I make it work with Tesseract Version 3.05
I downloaded the **tessdata** from this URL.
https://github.com/tesseract-ocr/tessdata/tree/3.04.00

## Why Tesseract Version 4.0 did not work?
- Since it's working with 3.05, I just switched to 4.0 Binaries.
- I tried with x86 and x64 dlls
- I downloaded **tessdata** from this URL https://github.com/tesseract-ocr/tessdata
- Also, I tried **tessdata** from this URL https://github.com/tesseract-ocr/tessdata_best
- I switched to English just to check if it's related to **tessdata** or Data
- All trials failed! The exception is not helpful and it cannot guide to fix the issue!!!
