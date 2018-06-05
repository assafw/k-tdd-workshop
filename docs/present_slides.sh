#!/bin/bash

if ! [ -x "$(command -v reveal-md)" ]; then
	npm install -g reveal-md;
fi

reveal-md ./slides.md
