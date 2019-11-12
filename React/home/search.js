import React from 'react';
import Autosuggest from 'react-autosuggest';
import axios from 'axios';

function getSuggestionValue(suggestion) {
    return suggestion.fio;
}

function renderSuggestion(suggestion) {
    return (
        <a>{suggestion.fio}</a>
    );
}

class Search extends React.Component {
    constructor(props) {
        super(props);

        this.state = {
            value: '',
            suggestions: []
        };
    }

    clearInput = () => {
        this.setState({
            value: ''
        });
    }

    onChange = (event, { newValue, method }) => {
        //console.log(newValue)
        this.setState({
            value: newValue
        });
    };

    onSuggestionsFetchRequested = ({ value }) => {
        axios.get("api/student/search/" + value)
            .then(response => this.setState({ suggestions: response.data }));
    }

    onSuggestionSelected = (event, { suggestion, suggestionValue }) => {
        this.props.setStudentID(suggestion.number);
    }

    onSuggestionsClearRequested = () => {
        this.setState({
            suggestions: []
        });
    };

    render() {
        const { value, suggestions } = this.state;
        const inputProps = {
            placeholder: "Введите ФИО студента",
            value,
            onChange: this.onChange
        };
        const theme = {
            container: 'autosuggest',
            input: 'form-control',
            suggestionsContainer: 'dropdown',
            suggestionsList: `dropdown-menu ${suggestions.length ? 'show' : ''}`,
            suggestion: 'dropdown-item',
            suggestionFocused: 'active'
        };

        return (
            <Autosuggest
                suggestions={suggestions}
                onSuggestionsFetchRequested={this.onSuggestionsFetchRequested}
                onSuggestionsClearRequested={this.onSuggestionsClearRequested}
                getSuggestionValue={getSuggestionValue}
                renderSuggestion={renderSuggestion}
                onSuggestionSelected={this.onSuggestionSelected}
                focusInputOnSuggestionClick={false}
                inputProps={inputProps}
                theme={theme}
            />
        );
    }
}

export default Search;