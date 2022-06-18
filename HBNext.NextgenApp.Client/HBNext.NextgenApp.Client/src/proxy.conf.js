const PROXY_CONFIG = [
  {
    context: [
      "/incident",
    ],
    target: "https://localhost:7080",
    secure: false
  }
]

module.exports = PROXY_CONFIG;
