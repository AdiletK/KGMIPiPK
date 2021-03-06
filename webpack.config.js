"use strict";

var path = require("path");
var WebpackNotifierPlugin = require("webpack-notifier");
var BrowserSyncPlugin = require("browser-sync-webpack-plugin");

module.exports = {
    entry: {
        home: "./js/home/index.js",
        lextures: "./js/lextures/index.js",
        groups: "./js/groups/index.js",
        grouplists: "./js/grouplists/index.js",
    },
    output: {
        path: path.join(__dirname, "wwwroot/dist"),
        filename: "[name].js",
        publicPath: 'dist/',
        library: ["[name]"],
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