"use strict";

var path = require("path");
var WebpackNotifierPlugin = require("webpack-notifier");
var BrowserSyncPlugin = require("browser-sync-webpack-plugin");

module.exports = {
    entry: {
       home: "./React/home/index.js",
       lextures: "./React/lextures/index.js"
    },
    output: {
        path: path.join(__dirname, "wwwroot/dist"),
        filename: "Lib.[name].js",
        publicPath: 'dist/',
        library: ["Lib", "[name]"],
        libraryTarget: "var"
        
    },
    module: {
        rules: [
            {
                test: /\.(js|jsx)/,
                exclude: /node_modules/,
                use: {
                    loader: "babel-loader"
                }
            },
            {
                test: /\.css$/i,
                use: ['style-loader', 'css-loader'],
            },
        ]
    },
    watchOptions: {
        poll: 1000 // Check for changes every second
    },
    devtool: "inline-source-map",
    plugins: [new WebpackNotifierPlugin(), new BrowserSyncPlugin()]
};

