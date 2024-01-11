---
updated: 2023-09-20 11:54:42
---
## 目录结构
~~~
.
├── breakings                # 破坏性更改
│   ├── 2.2.0
│   ├── 2.2.1
│   ├── 2.2.3
│   └── breaking.yml.example
├── CHANGELOG.en-US.md       # 更新日志（英文）
├── codecov.yml              # Codecov 配置文件
├── CODE_OF_CONDUCT.md       # 行为准则
├── commitlint.config.js     # Commitlint 配置文件（JavaScript）
├── commitlint.config.ts     # Commitlint 配置文件（TypeScript）
├── CONTRIBUTING.md          # 贡献指南
├── docs                     # 文档
│   ├── components.d.ts
│   ├── crowdin.yml
│   ├── en-US
│   ├── examples
│   ├── index.md
│   ├── package.json
│   ├── public
│   ├── tsconfig.json
│   ├── unocss.config.ts
│   └── vite.config.ts
├── global.d.ts              # 全局类型定义
├── internal                 # 内部工具和配置
│   ├── build
│   ├── build-constants
│   ├── build-utils
│   ├── eslint-config
│   └── metadata
├── LICENSE                  # 许可证
├── package.json             # 项目依赖和配置
├── packages                 # 组件、指令、主题等包
│   ├── components
│   ├── constants
│   ├── directives
│   ├── element-plus
│   ├── hooks
│   ├── locale
│   ├── test-utils
│   ├── theme-chalk
│   └── utils
├── play                     # 示例应用
│   ├── app.example.vue
│   ├── env.d.ts
│   ├── index.html
│   ├── main.ts
│   ├── package.json
│   ├── src
│   ├── vite.config.ts
│   └── vite.init.ts
├── pnpm-lock.yaml           # PNPM 锁文件
├── pnpm-workspace.yaml      # PNPM 工作区配置
├── README.md                # 项目说明文档
├── scripts                  # 构建和发布脚本
│   ├── build-table.ts
│   ├── file-check.sh
│   ├── gc.sh
│   ├── gen-version.ts
│   ├── nightly.sh
│   ├── publish.sh
│   └── update-version.ts
├── ssr-testing              # 服务器端渲染测试
│   ├── assets
│   ├── cases
│   ├── demo.spec.puppeteer.tsx
│   ├── index.html
│   ├── tsconfig.json
│   └── vitest.config.ts
├── tsconfig.base.json       # TypeScript 基础配置
├── tsconfig.json            # TypeScript 配置
├── tsconfig.node.json       # TypeScript 配置（Node.js）
├── tsconfig.play.json       # TypeScript 配置（示例应用）
├── tsconfig.vite-config.json # TypeScript 配置（Vite 配置）
├── tsconfig.vitest.json     # TypeScript 配置（Vitest）
├── tsconfig.web.json        # TypeScript 配置（Web）
├── typings                  # 类型定义
│   ├── components.d.ts
│   ├── env.d.ts
│   └── vue-test-utils.d.ts
├── vitest.config.ts         # Vitest 配置
└── vitest.setup.ts          # Vitest 设置

~~~

## 构建
