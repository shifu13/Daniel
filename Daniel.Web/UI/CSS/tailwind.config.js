module.exports = {
    content: [
        // these are relative to package.json
        './UI/Scripts/**/*.js',
        './Views/**/*.cshtml'
    ],
    theme: {
        fontFamily: {
            montserrat: ['Montserrat', 'sans-serif'],
            karla: ['Karla', 'sans-serif'],
        },
        container: {
            center: true,
            padding: {
                DEFAULT: '1rem',
            },
        },
        extend: {
            colors: {
                'ui': {
                    'blue': {
                        DEFAULT: '#2986cc'
                    },

                },
            },
            fontSize: {
                inherit: "inherit",
                ...[...Array(256).keys()].map(i => i / 16 + 'rem')
            },
        },
    },
    variants: {
        extend: {
            margin: ['last', 'first', 'hover', 'group-hover'],
            padding: ['last', 'first'],
            translate: ['active', 'group-hover'],
            backgroundColor: ['first', 'last', 'responsive'],
            textColor: ['first', 'last', 'hover'],
            order: ['odd', 'even'],
            scale: ['responsive', 'hover', 'focus', 'active', 'group-hover'],
            borderColor: ['first', 'last'],
            borderStyle: ['first', 'last'],
            borderWidth: ['first', 'last'],
            display: ['first', 'last'],
            width: ['first', 'last']
        }
    },
    plugins: [
        require('@tailwindcss/typography')
    ],
}