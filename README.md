## Usage

### CLI

To use this as a CLI locally, first install
[babashka](https://github.com/babashka/babashka#installation) and
[clojure](https://clojure.org/guides/install_clojure). Then:

```sh
$ git clone https://github.com/logseq/publish-spa
$ cd publish-spa && yarn install
$ yarn global add $PWD or npm install -g $PWD
```

This CLI depends on Logseq being checked out locally in order to build the
static directory for it. If you haven't built the static directory, you'll need
to do it once (takes some time):

```sh
$ git clone https://github.com/logseq/logseq && cd logseq
# Switch to a stable version
$ git checkout 0.9.2
# Install deps and build static directory
$ yarn install --frozen-lockfile && yarn gulp:build && clojure -M:cljs release publishing
```

Then use the CLI from any logseq graph directory!

```sh
$ logseq-publish-spa out
Parsing 306 files...
Export public pages and publish assets to out successfully 🎉
```

## MORE

to see: https://github.com/logseq/publish-spa
